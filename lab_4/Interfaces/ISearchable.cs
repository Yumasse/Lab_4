using lab_4;
using System;

public interface ISearchable
{
    List<Goods> Search(decimal minPrice, decimal maxPrice, string category);
}
