﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails125.  ISO2002 ID# _o1LvxYymEea-QrbCUXny2w.
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
public partial record SettlementDetails125
     : IIsoXmlSerilizable<SettlementDetails125>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    public required SecuritiesTransactionType33Choice_ SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public SettlementTransactionCondition17Choice_? SettlementTransactionCondition { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    public MarketClientSide4Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    public Registration9Choice_? Registration { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    public RepurchaseType13Choice_? RepurchaseType { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    
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
        writer.WriteStartElement(null, "SctiesTxTp", xmlNamespace );
        SecuritiesTransactionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SettlementTransactionCondition is SettlementTransactionCondition17Choice_ SettlementTransactionConditionValue)
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
        if (CashClearingSystem is CashSettlementSystem4Choice_ CashClearingSystemValue)
        {
            writer.WriteStartElement(null, "CshClrSys", xmlNamespace );
            CashClearingSystemValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MarketClientSide is MarketClientSide4Choice_ MarketClientSideValue)
        {
            writer.WriteStartElement(null, "MktClntSd", xmlNamespace );
            MarketClientSideValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Registration is Registration9Choice_ RegistrationValue)
        {
            writer.WriteStartElement(null, "Regn", xmlNamespace );
            RegistrationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepurchaseType is RepurchaseType13Choice_ RepurchaseTypeValue)
        {
            writer.WriteStartElement(null, "RpTp", xmlNamespace );
            RepurchaseTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesRTGS is SecuritiesRTGS4Choice_ SecuritiesRTGSValue)
        {
            writer.WriteStartElement(null, "SctiesRTGS", xmlNamespace );
            SecuritiesRTGSValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (StampDutyTaxBasis is GenericIdentification30 StampDutyTaxBasisValue)
        {
            writer.WriteStartElement(null, "StmpDtyTaxBsis", xmlNamespace );
            StampDutyTaxBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SettlementDetails125 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
