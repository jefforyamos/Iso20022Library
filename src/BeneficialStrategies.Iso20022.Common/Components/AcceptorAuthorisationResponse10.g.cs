﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorAuthorisationResponse10.  ISO2002 ID# __hcu4S5HEeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
public partial record AcceptorAuthorisationResponse10
     : IIsoXmlSerilizable<AcceptorAuthorisationResponse10>
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment77 Environment { get; init; } 
    /// <summary>
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction111 Transaction { get; init; } 
    /// <summary>
    /// Authorisation response from the acquirer.
    /// Authorisation of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction109 TransactionResponse { get; init; } 
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "Envt", xmlNamespace );
        Environment.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tx", xmlNamespace );
        Transaction.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TxRspn", xmlNamespace );
        TransactionResponse.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AcceptorAuthorisationResponse10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
