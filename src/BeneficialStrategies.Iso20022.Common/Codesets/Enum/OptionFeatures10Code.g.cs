﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionFeatures10Code.  ISO2002 ID# _SYqCoYcmEeavwKddCbm3hg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "ASVO".
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_SwKjsYcmEeavwKddCbm3hg")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption = OptionFeaturesCode.AccountServicerOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as "BOIS".
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_SwKjs4cmEeavwKddCbm3hg")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction = OptionFeaturesCode.BeneficiaryOwnerInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as "COND".
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_SwKjtYcmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as "MAXC".
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_SwKjt4cmEeavwKddCbm3hg")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as "MAXS".
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_SwKjuYcmEeavwKddCbm3hg")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).
    /// Encoded/decoded by serializers as "NOSE".
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_SwKju4cmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).")]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as "OPLF".
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_SwKjvYcmEeavwKddCbm3hg")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as "CAOS".
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_SwKjv4cmEeavwKddCbm3hg")]
    [Description(@"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.")]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as "PINS".
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_SwKjwYcmEeavwKddCbm3hg")]
    [Description(@"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.")]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as "PROR".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_SwKjw4cmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as "VVPR".
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_SwKjxYcmEeavwKddCbm3hg")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder should only instruct a cash amount.
    /// Encoded/decoded by serializers as "QCAS".
    /// </summary>
    [EnumMember(Value = "QCAS")]
    [IsoId("_VCHYMYcmEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder should only instruct a cash amount.")]
    InstructCashAmount = OptionFeaturesCode.InstructCashAmount, // same ordinal as derivation source for type conversions
    
}
