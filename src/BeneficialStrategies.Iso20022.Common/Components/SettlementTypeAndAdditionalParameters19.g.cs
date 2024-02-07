﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTypeAndAdditionalParameters19.  ISO2002 ID# _cAsREY6_Eeaa5_S8lsRKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
public partial record SettlementTypeAndAdditionalParameters19
     : IIsoXmlSerilizable<SettlementTypeAndAdditionalParameters19>
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    /// <summary>
    /// Indicates whether the settlement transaction was already sent on the market and that it is only sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoMax35Text? ClientCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification identifying the triparty collateral management transaction from the triparty-agent's/service-provider's point of view.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty-agent/service-provider.
    /// </summary>
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoMax35Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReconciliationIndicator is IsoYesNoIndicator ReconciliationIndicatorValue)
        {
            writer.WriteStartElement(null, "RcncltnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ReconciliationIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralInstructionIdentification is IsoMax35Text ClientCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientCollateralInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralTransactionIdentification is IsoMax35Text ClientCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralTransactionIdentification is IsoMax35Text TripartyAgentServiceProviderCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripartyAgentServiceProviderCollateralTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentServiceProviderCollateralInstructionIdentification is IsoMax35Text TripartyAgentServiceProviderCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtSvcPrvdrCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TripartyAgentServiceProviderCollateralInstructionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static SettlementTypeAndAdditionalParameters19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
