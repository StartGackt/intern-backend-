namespace MyWebApi.Entities.ResponseModels
{

    public class DataSourceResponse<T>
    {
        public List<T> DataSource { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}
