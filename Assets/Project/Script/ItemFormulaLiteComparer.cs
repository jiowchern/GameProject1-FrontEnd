using System.Collections.Generic;


using Regulus.Project.ItIsNotAGame1.Data;

public class ItemFormulaLiteComparer : IEqualityComparer<ItemFormulaLite>
{
    bool IEqualityComparer<ItemFormulaLite>.Equals(ItemFormulaLite x, ItemFormulaLite y)
    {
        return x.Id == y.Id;
    }

    int IEqualityComparer<ItemFormulaLite>.GetHashCode(ItemFormulaLite obj)
    {
        return obj.GetHashCode();
    }
}