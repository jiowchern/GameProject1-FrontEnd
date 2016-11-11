using System.Collections.Generic;


using Regulus.Project.ItIsNotAGame1.Data;

public class ItemFormulaLiteComparer : IEqualityComparer<ItemFormulaLite>
{
    bool IEqualityComparer<ItemFormulaLite>.Equals(ItemFormulaLite x, ItemFormulaLite y)
    {
        return x.Name == y.Name;
    }

    int IEqualityComparer<ItemFormulaLite>.GetHashCode(ItemFormulaLite obj)
    {
        return obj.GetHashCode();
    }
}