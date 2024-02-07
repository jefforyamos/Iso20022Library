﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails101.  ISO2002 ID# _kkwrUWaPEeWZev0W8F756g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
public partial record SettlementDetails101
     : IIsoXmlSerilizable<SettlementDetails101>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public HoldIndicator6? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public PriorityNumeric4Choice_? Priority { get; init; } 
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    public required SecuritiesTransactionType21Choice_ SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public SettlementTransactionCondition20Choice_? SettlementTransactionCondition { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    public BlockTrade4Choice_? BlockTrade { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    public ExposureType16Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    public MarketClientSide4Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    public Registration9Choice_? Registration { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    public RepurchaseType14Choice_? RepurchaseType { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public Restriction5Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    public Tracking4Choice_? Tracking { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public AutomaticBorrowing6Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    public IsoYesNoIndicator? ReturnLeg { get; init; } 
    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    
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
        if (HoldIndicator is HoldIndicator6 HoldIndicatorValue)
        {
            writer.WriteStartElement(null, "HldInd", xmlNamespace );
            HoldIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Priority is PriorityNumeric4Choice_ PriorityValue)
        {
            writer.WriteStartElement(null, "Prty", xmlNamespace );
            PriorityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesTxTp", xmlNamespace );
        SecuritiesTransactionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementTransactionCondition is SettlementTransactionCondition20Choice_ SettlementTransactionConditionValue)
        {
            writer.WriteStartElement(null, "SttlmTxCond", xmlNamespace );
            SettlementTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartialSettlementIndicator is SettlementTransactionCondition5Code PartialSettlementIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtlSttlmInd", xmlNamespace );
            writer.WriteValue(PartialSettlementIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BeneficialOwnership is BeneficialOwnership4Choice_ BeneficialOwnershipValue)
        {
            writer.WriteStartElement(null, "BnfclOwnrsh", xmlNamespace );
            BeneficialOwnershipValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockTrade is BlockTrade4Choice_ BlockTradeValue)
        {
            writer.WriteStartElement(null, "BlckTrad", xmlNamespace );
            BlockTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CCPEligibility is CentralCounterPartyEligibility4Choice_ CCPEligibilityValue)
        {
            writer.WriteStartElement(null, "CCPElgblty", xmlNamespace );
            CCPEligibilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveryReturnReason is DeliveryReturn3Choice_ DeliveryReturnReasonValue)
        {
            writer.WriteStartElement(null, "DlvryRtrRsn", xmlNamespace );
            DeliveryReturnReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashClearingSystem is CashSettlementSystem4Choice_ CashClearingSystemValue)
        {
            writer.WriteStartElement(null, "CshClrSys", xmlNamespace );
            CashClearingSystemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExposureType is ExposureType16Choice_ ExposureTypeValue)
        {
            writer.WriteStartElement(null, "XpsrTp", xmlNamespace );
            ExposureTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FXStandingInstruction is FXStandingInstruction4Choice_ FXStandingInstructionValue)
        {
            writer.WriteStartElement(null, "FxStgInstr", xmlNamespace );
            FXStandingInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketClientSide is MarketClientSide4Choice_ MarketClientSideValue)
        {
            writer.WriteStartElement(null, "MktClntSd", xmlNamespace );
            MarketClientSideValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NettingEligibility is NettingEligibility4Choice_ NettingEligibilityValue)
        {
            writer.WriteStartElement(null, "NetgElgblty", xmlNamespace );
            NettingEligibilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registration is Registration9Choice_ RegistrationValue)
        {
            writer.WriteStartElement(null, "Regn", xmlNamespace );
            RegistrationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepurchaseType is RepurchaseType14Choice_ RepurchaseTypeValue)
        {
            writer.WriteStartElement(null, "RpTp", xmlNamespace );
            RepurchaseTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalRestrictions is Restriction5Choice_ LegalRestrictionsValue)
        {
            writer.WriteStartElement(null, "LglRstrctns", xmlNamespace );
            LegalRestrictionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesRTGS is SecuritiesRTGS4Choice_ SecuritiesRTGSValue)
        {
            writer.WriteStartElement(null, "SctiesRTGS", xmlNamespace );
            SecuritiesRTGSValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlingCapacity is SettlingCapacity7Choice_ SettlingCapacityValue)
        {
            writer.WriteStartElement(null, "SttlgCpcty", xmlNamespace );
            SettlingCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementSystemMethod is SettlementSystemMethod4Choice_ SettlementSystemMethodValue)
        {
            writer.WriteStartElement(null, "SttlmSysMtd", xmlNamespace );
            SettlementSystemMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxCapacity is TaxCapacityParty4Choice_ TaxCapacityValue)
        {
            writer.WriteStartElement(null, "TaxCpcty", xmlNamespace );
            TaxCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StampDutyTaxBasis is GenericIdentification30 StampDutyTaxBasisValue)
        {
            writer.WriteStartElement(null, "StmpDtyTaxBsis", xmlNamespace );
            StampDutyTaxBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tracking is Tracking4Choice_ TrackingValue)
        {
            writer.WriteStartElement(null, "Trckg", xmlNamespace );
            TrackingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AutomaticBorrowing is AutomaticBorrowing6Choice_ AutomaticBorrowingValue)
        {
            writer.WriteStartElement(null, "AutomtcBrrwg", xmlNamespace );
            AutomaticBorrowingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LetterOfGuarantee is LetterOfGuarantee4Choice_ LetterOfGuaranteeValue)
        {
            writer.WriteStartElement(null, "LttrOfGrnt", xmlNamespace );
            LetterOfGuaranteeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReturnLeg is IsoYesNoIndicator ReturnLegValue)
        {
            writer.WriteStartElement(null, "RtrLeg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ReturnLegValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ModificationCancellationAllowed is ModificationCancellationAllowed4Choice_ ModificationCancellationAllowedValue)
        {
            writer.WriteStartElement(null, "ModCxlAllwd", xmlNamespace );
            ModificationCancellationAllowedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EligibleForCollateral is IsoYesNoIndicator EligibleForCollateralValue)
        {
            writer.WriteStartElement(null, "ElgblForColl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EligibleForCollateralValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SecuritiesSubBalanceType is GenericIdentification30 SecuritiesSubBalanceTypeValue)
        {
            writer.WriteStartElement(null, "SctiesSubBalTp", xmlNamespace );
            SecuritiesSubBalanceTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashSubBalanceType is GenericIdentification30 CashSubBalanceTypeValue)
        {
            writer.WriteStartElement(null, "CshSubBalTp", xmlNamespace );
            CashSubBalanceTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementDetails101 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
