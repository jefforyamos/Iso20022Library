﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Pension5.  ISO2002 ID# _w2XZYelmEeuvhrZwLF0fDg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
public partial record Pension5
     : IIsoXmlSerilizable<Pension5>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    public PensionPolicy1? Identification { get; init; } 
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    public required PensionSchemeType3Choice_ Type { get; init; } 
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    public TaxReference1? TaxReference { get; init; } 
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    /// <summary>
    /// Drawdown status of the pension.
    /// </summary>
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    public DrawdownType2Choice_? DrawdownType { get; init; } 
    /// <summary>
    /// Number of drawdown tranches.
    /// </summary>
    public IsoNumber? NumberOfDrawdownTranches { get; init; } 
    /// <summary>
    /// Estimated value of the pension policy, plan or scheme.
    /// </summary>
    public DateAndAmount2? EstimatedValue { get; init; } 
    /// <summary>
    /// Indicates whether the transfer forms part of a block transfer.
    /// </summary>
    public IsoYesNoIndicator? BlockTransfer { get; init; } 
    /// <summary>
    /// When the transfer is part of a block transfer, reference to link several items.
    /// </summary>
    public IsoMax35Text? BlockTransferReference { get; init; } 
    /// <summary>
    /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
    /// </summary>
    public IsoYesNoIndicator? TaxFreeCashProtection { get; init; } 
    /// <summary>
    /// Amount of cash that is tax free.
    /// </summary>
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    /// <summary>
    /// Value of the pension policy, plan or scheme.
    /// </summary>
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has retirement age protection.
    /// </summary>
    public IsoYesNoIndicator? RetirementAgeProtection { get; init; } 
    /// <summary>
    /// Age at which the pension policy, plan or scheme holder retires.
    /// </summary>
    public IsoDecimalNumber? RetirementAge { get; init; } 
    /// <summary>
    /// Indicates whether the pension benefits are shared.
    /// </summary>
    public IsoYesNoIndicator? Sharing { get; init; } 
    /// <summary>
    /// Type of lump sum paid to a member of the pension policy, plan or scheme.
    /// </summary>
    public LumpSumType1Choice_? LumpSumType { get; init; } 
    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    public PensionOrder1? PensionOrder { get; init; } 
    /// <summary>
    /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
    /// </summary>
    public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; } 
    /// <summary>
    /// Money Purchase Annual Allowance (MPAA) details.
    /// </summary>
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
    /// </summary>
    public IsoYesNoIndicator? SafeguardBenefit { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has non-safeguarded guaranteed benefits.
    /// </summary>
    public IsoYesNoIndicator? NonSafeguardedGuaranteedBenefits { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
    /// </summary>
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    /// <summary>
    /// Indicates whether the client has any lifetime allowance protection.
    /// </summary>
    public IsoYesNoIndicator? ClientLifetimeAllowanceProtection { get; init; } 
    /// <summary>
    /// Indicates whether a benefit crystallisation event (BCE) has occurred. This includes ‘age 75 checks’.
    /// </summary>
    public IsoYesNoIndicator? BenefitCrystallisationEventOccurred { get; init; } 
    /// <summary>
    /// Indicates that the transfer is only in relation to underlying assets, and that the wrapper transfer will occur separately.
    /// </summary>
    public IsoYesNoIndicator? NonWrapperTransfer { get; init; } 
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Identification is PensionPolicy1 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransferScope is PensionTransferScope1Choice_ TransferScopeValue)
        {
            writer.WriteStartElement(null, "TrfScp", xmlNamespace );
            TransferScopeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxReference is TaxReference1 TaxReferenceValue)
        {
            writer.WriteStartElement(null, "TaxRef", xmlNamespace );
            TaxReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DrawdownTrancheIdentification is IsoMax35Text DrawdownTrancheIdentificationValue)
        {
            writer.WriteStartElement(null, "DrwdwnTrchId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DrawdownTrancheIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DrawdownStatus is DrawdownStatus1Choice_ DrawdownStatusValue)
        {
            writer.WriteStartElement(null, "DrwdwnSts", xmlNamespace );
            DrawdownStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DrawdownType is DrawdownType2Choice_ DrawdownTypeValue)
        {
            writer.WriteStartElement(null, "DrwdwnTp", xmlNamespace );
            DrawdownTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NumberOfDrawdownTranches is IsoNumber NumberOfDrawdownTranchesValue)
        {
            writer.WriteStartElement(null, "NbOfDrwdwnTrnchs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(NumberOfDrawdownTranchesValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (EstimatedValue is DateAndAmount2 EstimatedValueValue)
        {
            writer.WriteStartElement(null, "EstmtdVal", xmlNamespace );
            EstimatedValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockTransfer is IsoYesNoIndicator BlockTransferValue)
        {
            writer.WriteStartElement(null, "BlckTrf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BlockTransferValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (BlockTransferReference is IsoMax35Text BlockTransferReferenceValue)
        {
            writer.WriteStartElement(null, "BlckTrfRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(BlockTransferReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TaxFreeCashProtection is IsoYesNoIndicator TaxFreeCashProtectionValue)
        {
            writer.WriteStartElement(null, "TaxFreeCshPrtcn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(TaxFreeCashProtectionValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (TaxFreeCashAmount is DateAndAmount2 TaxFreeCashAmountValue)
        {
            writer.WriteStartElement(null, "TaxFreeCshAmt", xmlNamespace );
            TaxFreeCashAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueOfPensionPolicyOrPlanOrScheme is DateAndAmount2 ValueOfPensionPolicyOrPlanOrSchemeValue)
        {
            writer.WriteStartElement(null, "ValOfPnsnPlcyOrPlanOrSchme", xmlNamespace );
            ValueOfPensionPolicyOrPlanOrSchemeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RetirementAgeProtection is IsoYesNoIndicator RetirementAgeProtectionValue)
        {
            writer.WriteStartElement(null, "RtrmntAgePrtcn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RetirementAgeProtectionValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (RetirementAge is IsoDecimalNumber RetirementAgeValue)
        {
            writer.WriteStartElement(null, "RtrmntAge", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(RetirementAgeValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
        if (Sharing is IsoYesNoIndicator SharingValue)
        {
            writer.WriteStartElement(null, "Shrg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SharingValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (LumpSumType is LumpSumType1Choice_ LumpSumTypeValue)
        {
            writer.WriteStartElement(null, "LumpSumTp", xmlNamespace );
            LumpSumTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PensionOrder is PensionOrder1 PensionOrderValue)
        {
            writer.WriteStartElement(null, "PnsnOrdr", xmlNamespace );
            PensionOrderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RingFencedDrawdownAssets is IsoYesNoIndicator RingFencedDrawdownAssetsValue)
        {
            writer.WriteStartElement(null, "RingFncdDrwdwnAssts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(RingFencedDrawdownAssetsValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (MoneyPurchaseAnnualAllowance is MoneyPurchaseAnnualAllowance1 MoneyPurchaseAnnualAllowanceValue)
        {
            writer.WriteStartElement(null, "MnyPurchsAnlAllwnc", xmlNamespace );
            MoneyPurchaseAnnualAllowanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafeguardBenefit is IsoYesNoIndicator SafeguardBenefitValue)
        {
            writer.WriteStartElement(null, "SfgrdBnft", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SafeguardBenefitValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NonSafeguardedGuaranteedBenefits is IsoYesNoIndicator NonSafeguardedGuaranteedBenefitsValue)
        {
            writer.WriteStartElement(null, "NonSfgrddGrntedBnfts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NonSafeguardedGuaranteedBenefitsValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (LifetimeAllowanceProtection is IsoYesNoIndicator LifetimeAllowanceProtectionValue)
        {
            writer.WriteStartElement(null, "LftmAllwncPrtcn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(LifetimeAllowanceProtectionValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ClientLifetimeAllowanceProtection is IsoYesNoIndicator ClientLifetimeAllowanceProtectionValue)
        {
            writer.WriteStartElement(null, "ClntLftmAllwncPrtcn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ClientLifetimeAllowanceProtectionValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (BenefitCrystallisationEventOccurred is IsoYesNoIndicator BenefitCrystallisationEventOccurredValue)
        {
            writer.WriteStartElement(null, "BnftCrstllstnEvtOcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(BenefitCrystallisationEventOccurredValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NonWrapperTransfer is IsoYesNoIndicator NonWrapperTransferValue)
        {
            writer.WriteStartElement(null, "NonWrpprTrf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NonWrapperTransferValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Pension5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
