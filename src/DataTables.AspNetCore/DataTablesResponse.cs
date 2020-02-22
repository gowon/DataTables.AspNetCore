﻿namespace DataTables.AspNetCore
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    ///     A full result, as understood by jQuery DataTables.
    /// </summary>
    /// <typeparam name="T">The data type of each row.</typeparam>
    [DataContract]
    public class DataTablesResponse<T>
    {
        /// <summary>
        ///     The draw counter that this object is a response to - from the draw parameter sent as part of the data request.
        ///     Note that it is strongly recommended for security reasons that you cast this parameter to an integer, rather than
        ///     simply echoing back to the client what it sent in the draw parameter, in order to prevent Cross Site Scripting
        ///     (XSS) attacks.
        /// </summary>
        [DataMember(Name = "draw")]
        public int Draw { get; set; }

        /// <summary>
        ///     Total records, before filtering (i.e. the total number of records in the database)
        /// </summary>
        [DataMember(Name = "recordsTotal")]
        public int RecordsTotal { get; set; }

        /// <summary>
        ///     Total records, after filtering (i.e. the total number of records after filtering has been applied - not just the
        ///     number of records being returned for this page of data).
        /// </summary>
        [DataMember(Name = "recordsFiltered")]
        public int RecordsFiltered { get; set; }

        /// <summary>
        ///     The data to be displayed in the table.
        ///     This is an array of data source objects, one for each row, which will be used by DataTables.
        ///     Note that this parameter's name can be changed using the ajaxDT option's dataSrc property.
        /// </summary>
        [DataMember(Name = "data")]
        public IEnumerable<T> Data { get; set; }
    }
}