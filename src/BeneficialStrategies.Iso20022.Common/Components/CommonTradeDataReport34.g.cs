﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CommonTradeDataReport34.  ISO2002 ID# _lryYWQ1IEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract and transaction details.
/// </summary>
public partial record CommonTradeDataReport34
     : IIsoXmlSerilizable<CommonTradeDataReport34>
{
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    public ContractType8? ContractData { get; init; } 
    /// <summary>
    /// Data related specifically to a trade transaction.
    /// </summary>
    public required TradeTransaction25 TransactionData { get; init; } 
    
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
        if (ContractData is ContractType8 ContractDataValue)
        {
            writer.WriteStartElement(null, "CtrctData", xmlNamespace );
            ContractDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxData", xmlNamespace );
        TransactionData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static CommonTradeDataReport34 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
