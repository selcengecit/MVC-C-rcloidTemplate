﻿using MVC_CircloidTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CircloidTemplate.App_Classes
{
    public class UserCart
    {
        private List<Product> prdList = new List<Product>();
        public List<Product> PrdList {
            get
            {
                return prdList;
            }
            set
            {
                prdList = value;

            }
        }
        //private List<Product> prdList { get; set; } = new List<Product>();
    }
}