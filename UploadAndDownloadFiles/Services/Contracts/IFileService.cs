using UploadAndDownloadFiles.Entities;

namespace UploadAndDownloadFiles.Services.Contracts
{
    public interface IFileService
    {
        public byte[] GetFile(string fileName);
        public Task<FileDetail> SaveFileToDisc(IFormFile file);
        public Task<List<FileDetail>> SaveFilesToDisc(IList<IFormFile> files);
    }
}
