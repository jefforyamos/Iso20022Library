﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails106.  ISO2002 ID# _5-DVz5NLEeWGlc8L7oPDIg.
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
public partial record SettlementDetails106
     : IIsoXmlSerilizable<SettlementDetails106>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public PriorityNumeric5Choice_? Priority { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public SettlementTransactionCondition22Choice_? SettlementTransactionCondition { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    public MarketClientSide5Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    public FXStandingInstruction5Choice_? FXStandingInstruction { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    public BlockTrade5Choice_? BlockTrade { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    public NettingEligibility5Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    public Tracking5Choice_? Tracking { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    
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
        if (HoldIndicator is IsoYesNoIndicator HoldIndicatorValue)
        {
            writer.WriteStartElement(null, "HldInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(HoldIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (Priority is PriorityNumeric5Choice_ PriorityValue)
        {
            writer.WriteStartElement(null, "Prty", xmlNamespace );
            PriorityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementTransactionCondition is SettlementTransactionCondition22Choice_ SettlementTransactionConditionValue)
        {
            writer.WriteStartElement(null, "SttlmTxCond", xmlNamespace );
            SettlementTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlingCapacity is SettlingCapacity8Choice_ SettlingCapacityValue)
        {
            writer.WriteStartElement(null, "SttlgCpcty", xmlNamespace );
            SettlingCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StampDutyTaxBasis is GenericIdentification47 StampDutyTaxBasisValue)
        {
            writer.WriteStartElement(null, "StmpDtyTaxBsis", xmlNamespace );
            StampDutyTaxBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesRTGS is SecuritiesRTGS5Choice_ SecuritiesRTGSValue)
        {
            writer.WriteStartElement(null, "SctiesRTGS", xmlNamespace );
            SecuritiesRTGSValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BeneficialOwnership is BeneficialOwnership5Choice_ BeneficialOwnershipValue)
        {
            writer.WriteStartElement(null, "BnfclOwnrsh", xmlNamespace );
            BeneficialOwnershipValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashClearingSystem is CashSettlementSystem5Choice_ CashClearingSystemValue)
        {
            writer.WriteStartElement(null, "CshClrSys", xmlNamespace );
            CashClearingSystemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TaxCapacity is TaxCapacityParty5Choice_ TaxCapacityValue)
        {
            writer.WriteStartElement(null, "TaxCpcty", xmlNamespace );
            TaxCapacityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketClientSide is MarketClientSide5Choice_ MarketClientSideValue)
        {
            writer.WriteStartElement(null, "MktClntSd", xmlNamespace );
            MarketClientSideValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FXStandingInstruction is FXStandingInstruction5Choice_ FXStandingInstructionValue)
        {
            writer.WriteStartElement(null, "FxStgInstr", xmlNamespace );
            FXStandingInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockTrade is BlockTrade5Choice_ BlockTradeValue)
        {
            writer.WriteStartElement(null, "BlckTrad", xmlNamespace );
            BlockTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LegalRestrictions is Restriction6Choice_ LegalRestrictionsValue)
        {
            writer.WriteStartElement(null, "LglRstrctns", xmlNamespace );
            LegalRestrictionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementSystemMethod is SettlementSystemMethod5Choice_ SettlementSystemMethodValue)
        {
            writer.WriteStartElement(null, "SttlmSysMtd", xmlNamespace );
            SettlementSystemMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NettingEligibility is NettingEligibility5Choice_ NettingEligibilityValue)
        {
            writer.WriteStartElement(null, "NetgElgblty", xmlNamespace );
            NettingEligibilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CCPEligibility is CentralCounterPartyEligibility5Choice_ CCPEligibilityValue)
        {
            writer.WriteStartElement(null, "CCPElgblty", xmlNamespace );
            CCPEligibilityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tracking is Tracking5Choice_ TrackingValue)
        {
            writer.WriteStartElement(null, "Trckg", xmlNamespace );
            TrackingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AutomaticBorrowing is AutomaticBorrowing8Choice_ AutomaticBorrowingValue)
        {
            writer.WriteStartElement(null, "AutomtcBrrwg", xmlNamespace );
            AutomaticBorrowingValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PartialSettlementIndicator is SettlementTransactionCondition5Code PartialSettlementIndicatorValue)
        {
            writer.WriteStartElement(null, "PrtlSttlmInd", xmlNamespace );
            writer.WriteValue(PartialSettlementIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (EligibleForCollateral is IsoYesNoIndicator EligibleForCollateralValue)
        {
            writer.WriteStartElement(null, "ElgblForColl", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EligibleForCollateralValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static SettlementDetails106 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
