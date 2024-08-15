using UploadAndDownloadFiles.Entities;
using UploadAndDownloadFiles.Services.Contracts;

namespace UploadAndDownloadFiles.Services
{
    public class FileService : IFileService
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;

        public FileService(IHttpContextAccessor context)
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + "\\UploadDir\\";
        }


        //DOWNLOAD
        public byte[] GetFile(string fileName)
        {
            var filePath = _basePath + fileName;
            return File.ReadAllBytes(filePath);
        }


        //UPLOAD
        public async Task<FileDetail> SaveFileToDisc(IFormFile file)
        {
            FileDetail fileDetail = new FileDetail();

            var fileType = Path.GetExtension(file.FileName);
            var baseUrl = _context.HttpContext.Request.Host;

            if (fileType.ToLower() == ".pdf" || fileType.ToLower() == ".jpg" || fileType.ToLower() == ".png" || fileType.ToLower() == ".jpeg")
            {
                var docName = Path.GetFileName(file.FileName);
                if (file != null && file.Length > 0)
                {
                    var destination = Path.Combine(_basePath, "", docName);
                    fileDetail.DocName = docName;
                    fileDetail.DocType = fileType;
                    fileDetail.DocUrl = Path.Combine(baseUrl + "/api/file/v1/" + fileDetail.DocName);

                    using var stream = new FileStream(destination, FileMode.Create);
                    await file.CopyToAsync(stream);
                }
            }

            return fileDetail;
        }


        //MULTIPLE UPLOADS
        public async Task<List<FileDetail>> SaveFilesToDisc(IList<IFormFile> files)
        {
            List<FileDetail> list = new List<FileDetail>();

            foreach (var file in files)
            {
                list.Add(await SaveFileToDisc(file));
            }

            return list;
        }

    }
}
