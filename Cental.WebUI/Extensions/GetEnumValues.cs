using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Extensions
{
    public static class GetEnumValues
    {
        public static List<SelectListItem> GetEnums<T>()
        {
            var values=Enum.GetValues(typeof(T));
            var selectList=new List<SelectListItem>();
            foreach (var item in values)
            {
                selectList.Add(new SelectListItem
                {
                    Text = item.ToString(),
                    Value = item.ToString()
                });
            }
            return selectList;

        }
    }
}
