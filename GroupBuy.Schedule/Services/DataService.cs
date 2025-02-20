using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web;

namespace GroupBuy.Schedule.Services
{
    public class DataService
    {
        /// <summary>
        /// 取得該 model 底下的某個欄位值
        /// </summary>
        /// <param name="model">目標物件</param>
        /// <param name="propertyName">欄位名稱</param>
        /// <returns></returns>
        public static object GetModelValue(object model, string propertyName)
        {
            Type modelType = model.GetType();
            PropertyInfo property = modelType.GetProperty(propertyName);
            if (property == null)
            {
                return null;
            }
            return property.GetValue(model, null);
        }

        /// <summary>
        /// 取得該 model 底下的某個欄位值
        /// </summary>
        /// <param name="model">目標物件</param>
        /// <param name="propertyName">欄位名稱</param>
        /// <returns></returns>
        public static bool HasPropWithModel(object model, string propertyName)
        {
            Type modelType = model.GetType();
            PropertyInfo property = modelType.GetProperty(propertyName);
            return !(property == null);
        }

        /// <summary>
        /// 兩個 Model 合併 ，model 蓋掉 targetModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="targetModel"></param>
        /// <param name="model"></param>
        /// <param name="propertyNames"></param> 除了這裡的 property name 以外都 merge
        /// <returns></returns>
        public static T MergeData<T>(object targetModel, object model, List<string> propertyNames = null) where T : new()
        {
            Type targetModelType = targetModel.GetType();
            foreach (PropertyInfo p in targetModelType.GetProperties())
            {
                string name = p.Name;
                propertyNames = propertyNames ?? new List<string>();
                if (!propertyNames.Contains(name) && model != null && DataService.HasPropWithModel(model, p.Name))
                {
                    p.SetValue(targetModel, GetModelValue(model, p.Name));
                }
            }
            return (T)targetModel;
        }

        /// <summary>
        /// 單個 Model 合併成 T 型別
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="targetModel"></param>
        /// <param name="model"></param>
        /// <param name="propertyNames"></param> 除了這裡的 property name 以外都 merge
        /// <returns></returns>
        public static T MergeData<T>(object model, List<string> propertyNames = null) where T : new()
        {
            var targetModel = new T();
            Type targetModelType = targetModel.GetType();
            foreach (PropertyInfo p in targetModelType.GetProperties())
            {
                try {
                    string name = p.Name;
                    propertyNames = propertyNames ?? new List<string>();
                    if (!propertyNames.Contains(name) && model != null && DataService.HasPropWithModel(model, p.Name))
                    {
                        p.SetValue(targetModel, GetModelValue(model, p.Name));
                    }
                }
                catch (Exception) {
                    continue;
                }
            }
            return targetModel;
        }

        public static void SetModelProperty<TModel, TValue>(TModel model,string propertyName, TValue value)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Property name cannot be null or empty.", nameof(propertyName));
            }

            var propertyInfo = typeof(TModel).GetProperty(propertyName);
            if (propertyInfo == null)
            {
                // 如果 Model 沒有這個屬性，直接跳過不做
                return;
            }

            if (!propertyInfo.CanWrite)
            {
                throw new ArgumentException($"Property '{propertyName}' cannot be set as it is read-only.");
            }

            propertyInfo.SetValue(model, value);
        }

        public static string[] GetNewArrString(int count, string[] target) {
            var result = new string[count];
            for (var i = 0; i < target.Length; i++)
            {
                if (i <= count - 1) { 
                    result[i] = target[i];
                }
            }
            return result;
        }

        public static string UrlCombine(params string[] parts)
        {
            if (parts == null || parts.Length == 0)
            {
                throw new ArgumentException("No URL parts provided");
            }

            // 去掉每個部分的開頭和結尾的 '/'
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = parts[i].Trim('/');
            }

            // 使用 '/' 組合所有部分
            return string.Join("/", parts);
        }


        //public static DataSet ToDataSet<T>(this List<T> list, string tableName = null)
        //{
        //    if (list == null || list.Count == 0)
        //        return null;

        //    Type elementType = typeof(T);
        //    DataSet dataSet = new DataSet();
        //    if (tableName == null)
        //    {
        //        tableName = elementType.Name;
        //    }
        //    DataTable table = new DataTable(tableName);

        //    // 使用反射取得 T 的所有屬性
        //    var properties = elementType.GetProperties();

        //    // 將屬性作為欄位加入 DataTable
        //    foreach (var property in properties)
        //    {
        //        table.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
        //    }

        //    // 將 List<T> 的每個物件加入 DataTable
        //    foreach (var item in list)
        //    {
        //        DataRow row = table.NewRow();

        //        foreach (var property in properties)
        //        {
        //            row[property.Name] = property.GetValue(item) ?? DBNull.Value;
        //        }

        //        table.Rows.Add(row);
        //    }

        //    dataSet.Tables.Add(table);
        //    return dataSet;
        //}

    }

}
