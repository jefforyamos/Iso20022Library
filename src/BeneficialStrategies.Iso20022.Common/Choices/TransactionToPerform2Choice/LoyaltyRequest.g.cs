﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LoyaltyRequest.  ISO2002 ID# _ro9DwwxrEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionToPerform2Choice;

/// <summary>
/// Content of the Loyalty Request message.
/// </summary>
public partial record LoyaltyRequest : TransactionToPerform2Choice_
     , IIsoXmlSerilizable<LoyaltyRequest>
{
    #nullable enable
    
    /// <summary>
    /// To retrieve Card Acquisition Data.
    /// </summary>
    public CustomerOrder1? CustomerOrder { get; init; } 
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    public required LoyaltyTransaction2 Transaction { get; init; } 
    /// <summary>
    /// Data related to a Loyalty program or account.
    /// </summary>
    public LoyaltyRequestData2? Data { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CustomerOrder is CustomerOrder1 CustomerOrderValue)
        {
            writer.WriteStartElement(null, "CstmrOrdr", xmlNamespace );
            CustomerOrderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Data is LoyaltyRequestData2 DataValue)
        {
            writer.WriteStartElement(null, "Data", xmlNamespace );
            DataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new LoyaltyRequest Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
