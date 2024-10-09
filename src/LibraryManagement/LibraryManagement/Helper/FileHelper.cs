namespace LibraryManagement.Helper
{
	public static class FileHelper
	{
		public static bool SaveFile(IFormFile file, string uploadPath)
		{
			if (file == null || file.Length == 0)
				return false;
			if (!Directory.Exists(uploadPath))
				Directory.CreateDirectory(uploadPath);

			var fileName = Path.GetFileName(file.FileName);
			var filePath = Path.Combine(uploadPath, fileName);

			using(var stream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite))
			{
				file.CopyTo(stream);
			}
			return true;
		}

		public static bool DeleteFile(string filePath)
		{
			if(File.Exists(filePath))
			{
				File.Delete(filePath);
				return true;
			}
			return false;
		}

		public static FileStream FileStream(string filePath)
		{
			if(File.Exists(filePath))
			{
				return new FileStream(filePath, FileMode.Open, FileAccess.Read);
			}
			return null;
		}

		public static string GetContentType(string fileName)
		{
			var fileExtension = Path.GetExtension(fileName.ToLowerInvariant());

			switch (fileExtension)
			{
				case ".pdf":
					return "application/pdf";
				case ".jpg":
				case ".jpeg":
					return "image/jpeg";
				case ".png":
					return "image/png";
				default:
					return "application/octet-stream";
			}

		}


	}
}
