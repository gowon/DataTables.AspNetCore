namespace DataTables.AspNetCore
{
    /// <summary>
    ///     An order, as sent by jQuery DataTables when doing AJAX queries.
    /// </summary>
    public class DataTablesOrder
    {
        /// <summary>
        ///     Column to which ordering should be applied.
        ///     This is an index reference to the columns array of information that is also submitted to the server.
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        ///     Ordering direction for this column.
        ///     It will be dt-string asc or dt-string desc to indicate ascending ordering or descending ordering, respectively.
        /// </summary>
        public OrderDirection Dir { get; set; }
    }
}