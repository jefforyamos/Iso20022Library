﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageStatusRequestData1.  ISO2002 ID# _nVT1sN6eEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message TransactionStatus Request message.
/// </summary>
public partial record MessageStatusRequestData1
     : IIsoXmlSerilizable<MessageStatusRequestData1>
{
    #nullable enable
    
    /// <summary>
    /// Transaction identification.
    /// </summary>
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    /// <summary>
    /// Initiating Party information.
    /// </summary>
    public required GenericIdentification171 InitiatingParty { get; init; } 
    /// <summary>
    /// Request to reprint the POI receipt(s).
    /// </summary>
    public IsoTrueFalseIndicator? ReceiptReprintFlag { get; init; } 
    /// <summary>
    /// Customer or Cashier Receipt.
    /// </summary>
    public SimpleValueList<DocumentType7Code> DocumentQualifier { get; init; } = [];
    
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
        writer.WriteStartElement(null, "XchgId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(ExchangeIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InitgPty", xmlNamespace );
        InitiatingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ReceiptReprintFlag is IsoTrueFalseIndicator ReceiptReprintFlagValue)
        {
            writer.WriteStartElement(null, "RctRprntFlg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ReceiptReprintFlagValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DocQlfr", xmlNamespace );
        writer.WriteValue(DocumentQualifier.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static MessageStatusRequestData1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
