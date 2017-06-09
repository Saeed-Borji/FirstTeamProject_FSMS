using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer : BaseEntity
    {
        public Customer()
           : base()
        {
        }
        // **********
        public bool IsActive { get; set; }
        // **********

        // **********Firstname-نام
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Firstname { get; set; }
        // **********

        // **********Lastname-نام خانوادگی
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 30)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Lastname { get; set; }
        // **********

        // **********Father-نام پدر
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Fathername { get; set; }

        // **********

        // **********NationalCode-کد ملی
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 10, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string NationalCode { get; set; }
        // **********

        // **********CertificateNumber-شماره شناسنامه
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 10, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string CertificateNumber { get; set; }
        // **********

        // **********CertificateNumber-سریال شناسنامه
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 10, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string SerialCertificateNumber { get; set; }

        // **********EconomicCode-کد اقتصادی
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 10, MinimumLength = 10)]
        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string EconomicCode { get; set; }
        // **********


        public string Description { get; set; }
        // **********
    }
}

