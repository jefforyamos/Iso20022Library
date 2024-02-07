﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundSettlementParameters16.  ISO2002 ID# _rssUUZGVEem-9Y6mq5ZH3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
public partial record FundSettlementParameters16
     : IIsoXmlSerilizable<FundSettlementParameters16>
{
    #nullable enable
    
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    public TradeTransactionCondition8Choice_? TradeTransactionCondition { get; init; } 
    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    public SettlementTransactionCondition30Choice_? SettlementTransactionCondition { get; init; } 
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    public SettlementParties94? ReceivingSideDetails { get; init; } 
    
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
        if (TradeTransactionCondition is TradeTransactionCondition8Choice_ TradeTransactionConditionValue)
        {
            writer.WriteStartElement(null, "TradTxCond", xmlNamespace );
            TradeTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementTransactionCondition is SettlementTransactionCondition30Choice_ SettlementTransactionConditionValue)
        {
            writer.WriteStartElement(null, "SttlmTxCond", xmlNamespace );
            SettlementTransactionConditionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesSettlementSystemIdentification is IsoMax35Text SecuritiesSettlementSystemIdentificationValue)
        {
            writer.WriteStartElement(null, "SctiesSttlmSysId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SecuritiesSettlementSystemIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ReceivingSideDetails is SettlementParties94 ReceivingSideDetailsValue)
        {
            writer.WriteStartElement(null, "RcvgSdDtls", xmlNamespace );
            ReceivingSideDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FundSettlementParameters16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
