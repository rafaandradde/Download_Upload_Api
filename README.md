# Download_Upload_API

## O que é este projeto?

Este projeto serve como um exemplo prático, demonstrando a lógica fundamental para a implementação de funcionalidades de upload e download de arquivos. Ele é projetado para ilustrar de forma clara e objetiva como essas operações podem ser realizadas, oferecendo uma base sólida para a integração dessas funcionalidades em sistemas mais complexos.

## Upload:

![image](https://github.com/user-attachments/assets/0bfc9bac-51df-47f8-9440-c2c21fec0220)

No Postman, após executar a aplicação, defina a URL do método uploadFile utilizando o verbo HTTP POST.

![image](https://github.com/user-attachments/assets/6a8c8adf-819a-4a49-8363-909d9f388b4a)

No corpo da requisição (Body), selecione a opção "form-data" e adicione uma chave com o nome file do tipo File. Em seguida, selecione o arquivo que deseja enviar.

![image](https://github.com/user-attachments/assets/0f7aa326-cb67-41f5-8fb5-4a4f9262f150)

Ao enviar a requisição, o servidor responderá com um status 200 OK, incluindo o nome do arquivo, o tipo de extensão, e a URL do caminho onde o arquivo foi salvo.

![image](https://github.com/user-attachments/assets/912fb0ad-f7bd-4073-87e5-3f419e5254ef)

O arquivo enviado será salvo dentro do diretório UploadDir, que está localizado dentro do projeto.

![image](https://github.com/user-attachments/assets/88d27d3a-8689-45e8-9b1f-f34701f8e91d)

## Upload de varios arquivos:

Funciona de forma similar ao upload comum. No Postman, defina a URL para o método uploadMultipleFiles. No corpo da requisição (Body), selecione a opção 'form-data' e adicione uma chave chamada files (no plural) do tipo File. Em seguida, selecione os arquivos que deseja enviar.

![image](https://github.com/user-attachments/assets/14646f37-285c-4a72-b402-c8e8e1ac2a17)


##Download

No Postman, defina a URL para o método downloadFile, seguido de uma barra e o nome do arquivo, utilizando o verbo HTTP GET.

![image](https://github.com/user-attachments/assets/bdd0c235-e6c4-4a88-9d2a-c3271b53c6db)




