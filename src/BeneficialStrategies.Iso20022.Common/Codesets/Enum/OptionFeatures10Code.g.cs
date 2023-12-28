﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionFeatures10Code.  ISO2002 ID# _SYqCoYcmEeavwKddCbm3hg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SYqCoYcmEeavwKddCbm3hg")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures10Code
{
    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as "AccountServicerOption".
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_SwKjsYcmEeavwKddCbm3hg")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption,
    
    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as "BeneficiaryOwnerInstruction".
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_SwKjs4cmEeavwKddCbm3hg")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction,
    
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as "Conditional".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_SwKjtYcmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional,
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as "MaximumCash".
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_SwKjt4cmEeavwKddCbm3hg")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash,
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as "MaximumSecurities".
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_SwKjuYcmEeavwKddCbm3hg")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities,
    
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).
    /// Encoded/decoded by serializers as "NoServiceOffered".
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_SwKju4cmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).")]
    NoServiceOffered,
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as "OddLotPreference".
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_SwKjvYcmEeavwKddCbm3hg")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference,
    
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as "OptionApplicability".
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_SwKjv4cmEeavwKddCbm3hg")]
    [Description(@"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.")]
    OptionApplicability,
    
    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as "PreviousInstructionInvalidity".
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_SwKjwYcmEeavwKddCbm3hg")]
    [Description(@"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.")]
    PreviousInstructionInvalidity,
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as "Proration".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_SwKjw4cmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration,
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as "ReducedWithholdingTax".
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_SwKjxYcmEeavwKddCbm3hg")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax,
    
    /// <summary>
    /// Feature whereby the holder should only instruct a cash amount.
    /// Encoded/decoded by serializers as "InstructCashAmount".
    /// </summary>
    [EnumMember(Value = "QCAS")]
    [IsoId("_VCHYMYcmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder should only instruct a cash amount.")]
    InstructCashAmount,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionFeatures10CodeMetadataExtensions
{
    private static readonly OptionFeatures10CodeDropdownSource _dropdownSource = new OptionFeatures10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionFeatures10CodeDropdownRow GetMetadata(this OptionFeatures10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


