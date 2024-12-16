namespace HeinHtetNaing_ADI.Common.DTOs
{
    public record PagedResult<T_DATA>(
        List<T_DATA> Result,
        int TotalCount,
        int Offset,
        int Size)
    { }
}
