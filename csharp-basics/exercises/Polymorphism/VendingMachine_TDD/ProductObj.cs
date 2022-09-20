﻿namespace VendingMachine_TDD
{
    public class ProductObj
    {
        public struct Product
        {
            ///<summary>Gets or sets the available amount of product.</summary>
            public int Available { get; set; }

            ///<summary>Gets or sets the product price.</summary>
            public MoneyObj.Money Price { get; set; }

            ///<summary>Gets or sets the product name.</summary>
            public string Name { get; set; }
        }
    }
}