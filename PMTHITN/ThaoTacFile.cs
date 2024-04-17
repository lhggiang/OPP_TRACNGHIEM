using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace PMTHITN
{
    public class ThaoTacFile
    {
        //ghi dữ liệu tiếp vào file
        public static string WriteJsonToConstantFile<T>(T data, string jsonFilePath)
        {
            try
            {
                // Đọc dữ liệu cũ từ tệp (nếu có)
                string oldJsonString = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath, Encoding.UTF8) : "[]"; // Sử dụng mã hóa UTF-8
                // Chuyển đổi dữ liệu cũ thành một danh sách
                List<T> oldData = JsonSerializer.Deserialize<List<T>>(oldJsonString);

                // Thêm dữ liệu mới vào danh sách cũ
                oldData.Add(data);
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) // Sử dụng mã hóa UTF-8
                };
                // Chuyển đổi danh sách đã mở rộng thành chuỗi JSON
                string newJsonString = JsonSerializer.Serialize(oldData, options);
                Console.WriteLine(newJsonString);
                // Ghi lại toàn bộ dữ liệu (cũ và mới) vào tệp với mã hóa UTF-8
                File.WriteAllText(jsonFilePath, newJsonString, Encoding.UTF8);
                return "Lưu dữ liệu thành công";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}, Lưu dữ liệu không thành công";
            }
        }
        //xóa hết dữ liệu trong file mới ghi
        public static string WriteJsonToFile<T>(T data, string jsonFilePath)
        {
            try
            {
                // Serialize danh sách thành JSON
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) 
                };
                string jsonData = JsonSerializer.Serialize(data, options);

                // Ghi JSON vào tệp
                File.WriteAllText(jsonFilePath, jsonData);
                return "Lưu dữ liệu thành công";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}, Lưu dữ liệu không thành công";
            }
        }
        public static List<T> ReadJsonFromFile<T>(string jsonFilePath)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFilePath);
                List<T> loadedData = JsonSerializer.Deserialize<List<T>>(jsonString);
                return loadedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi đọc JSON từ tệp: {ex.Message}");
                return null;
            }
        }
        //lưu vào file dưới dạng list
        public static string WriteJsonToFile<T>(List<T> dataList, string jsonFilePath)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) // Sử dụng mã hóa UTF-8
                };
                string jsonData = JsonSerializer.Serialize(dataList, options);

                File.WriteAllText(jsonFilePath, jsonData);

                return "Lưu dữ liệu thành công";
            }
            catch (Exception ex)
            {
                return $"{ex.Message}, Lưu dữ liệu không thành công";
            }
        }
    }
}
