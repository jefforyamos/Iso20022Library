﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BillingTaxCalculationMethod1Code.  ISO2002 ID# _6Vd10pqlEeGSON8vddiWzQ_-401381436.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the tax calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Vd10pqlEeGSON8vddiWzQ_-401381436")]
[Description(@"Defines the tax calculation method.")]
[DerivedFrom(typeof(BillingTaxCalculationMethodCode))]
public enum BillingTaxCalculationMethod1Code
{
    /// <summary>
    /// No taxes are calculated or due on this account.
    /// Encoded/decoded by serializers as "NoTaxes".
    /// </summary>
    [EnumMember(Value = "NTAX")]
    [IsoId("_6Vd105qlEeGSON8vddiWzQ_-1535157938")]
    [Description(@"No taxes are calculated or due on this account.")]
    NoTaxes,
    
    /// <summary>
    /// Line-by-line per service calculation and settlement currency translation.
    /// Encoded/decoded by serializers as "MethodA".
    /// </summary>
    [EnumMember(Value = "MTDA")]
    [IsoId("_6Vd11JqlEeGSON8vddiWzQ_1775205103")]
    [Description(@"Line-by-line per service calculation and settlement currency translation.")]
    MethodA,
    
    /// <summary>
    /// Line-by-line per service calculation with settlement currency translation performed on the statement tax total.
    /// Encoded/decoded by serializers as "MethodB".
    /// </summary>
    [EnumMember(Value = "MTDB")]
    [IsoId("_6Vd11ZqlEeGSON8vddiWzQ_-1052613430")]
    [Description(@"Line-by-line per service calculation with settlement currency translation performed on the statement tax total.")]
    MethodB,
    
    /// <summary>
    /// Group tax calculation with group settlement currency translation.
    /// Encoded/decoded by serializers as "MethodC".
    /// </summary>
    [EnumMember(Value = "MTDC")]
    [IsoId("_6Vd11pqlEeGSON8vddiWzQ_1967073441")]
    [Description(@"Group tax calculation with group settlement currency translation.")]
    MethodC,
    
    /// <summary>
    /// Line-by-line per service calculation with all charges and taxes due in the pricing currency.
    /// Encoded/decoded by serializers as "MethodD".
    /// </summary>
    [EnumMember(Value = "MTDD")]
    [IsoId("_6Vd115qlEeGSON8vddiWzQ_-2002776348")]
    [Description(@"Line-by-line per service calculation with all charges and taxes due in the pricing currency.")]
    MethodD,
    
    /// <summary>
    /// Tax calculation method is not defined or unknown.
    /// Encoded/decoded by serializers as "Undefined".
    /// </summary>
    [EnumMember(Value = "UDFD")]
    [IsoId("_6Vd12JqlEeGSON8vddiWzQ_-535627585")]
    [Description(@"Tax calculation method is not defined or unknown.")]
    Undefined,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BillingTaxCalculationMethod1CodeMetadataExtensions
{
    private static readonly BillingTaxCalculationMethod1CodeDropdownSource _dropdownSource = new BillingTaxCalculationMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBillingTaxCalculationMethod1CodeDropdownRow GetMetadata(this BillingTaxCalculationMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


