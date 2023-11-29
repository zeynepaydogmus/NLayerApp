using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }

        public static CustomResponseDto<T> Success(int ststusCode, T data)
        {
            return new CustomResponseDto<T>
            {
                Data = data,
                StatusCode = ststusCode,
                Errors = null
            };
        }
        public static CustomResponseDto<T> Success(int ststusCode)
        {
            return new CustomResponseDto<T>
            {
             
                StatusCode = ststusCode
             
            };
        }

        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseDto<T>
            {

                StatusCode = statusCode,
                Errors = errors
         
            };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T>
            {

                StatusCode = statusCode,
                Errors = new List<string> { error }

            };
        }
    }
}
