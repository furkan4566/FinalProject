using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).GreaterThan(0);//0 dan büyük olmalı
            RuleFor(p => p.UnitPrice).NotEmpty();//boş bırakılamaz
            //RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//categoryıd 1 olan ürünler min 10 tl den başlamalı
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A ile başlamalı");//ürünler a ile başlamalı

        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
