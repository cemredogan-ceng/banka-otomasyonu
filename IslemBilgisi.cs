﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka_otomasyonu_210601028_210601048
{
    public class IslemBilgisi
    {
        public decimal Tutar { get; set; }
        public DateTime IslemTarihi { get; set; }
        public long HesapNo { get; set; }
        public string Detay { get; set; }

        public const decimal GunlukParaCekmeLimiti = 750;
    } 

}
