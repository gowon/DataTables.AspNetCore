namespace DataTables.AspNetCore
{
    using System.Runtime.Serialization;

    /// <summary>
    ///     The additional columns that you can send to jQuery DataTables for automatic processing.
    /// </summary>
    // https://datatables.net/manual/server-side#Returned-data
    [DataContract]
    public abstract class DataTablesRow
    {
        /// <summary>
        ///     Set the ID property of the dt-tag tr node to this value
        /// </summary>
        [DataMember(Name = "DT_RowId")]
        public abstract string Id { get; }


        /// <summary>
        ///     Add this class to the dt-tag tr node
        /// </summary>
        [DataMember(Name = "DT_RowClass")]
        public abstract string Class { get; }

        /// <summary>
        ///     Add this data property to the row's dt-tag tr node allowing abstract data to be added to the node, using the HTML5
        ///     data-* attributes.
        ///     This uses the jQuery data() method to set the data, which can also then be used for later retrieval (for example on
        ///     a click event).
        /// </summary>
        [DataMember(Name = "DT_RowData")]
        public abstract object Data { get; }

        /// <summary>
        ///     Add the data contained in the object to the row tr node as attributes. The object keys are used as the attribute
        ///     keys and the values as the corresponding attribute values. This is performed using using the jQuery param() method.
        ///     Please note that this option requires DataTables 1.10.5 or newer.
        /// </summary>
        [DataMember(Name = "DT_RowAttr")]
        public abstract object Attributes { get; }
    }
}