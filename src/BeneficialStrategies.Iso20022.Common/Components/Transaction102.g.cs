﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction102.  ISO2002 ID# _Mt51QVW5EeeiG_nL4vgKnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment transaction.
/// </summary>
public partial record Transaction102
     : IIsoXmlSerilizable<Transaction102>
{
    #nullable enable
    
    /// <summary>
    /// Detailed description of an error that caused the message to be corrected/amended. Transmitted for further analysis.
    /// </summary>
    public DetailedError1? AmendedData { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _M6lmYVW5EeeiG_nL4vgKnQ
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification10 TransactionIdentification { get; init; } 
    /// <summary>
    /// Original message before correction/amendment.
    /// </summary>
    public IsoMax100KBinary? OriginalMessage { get; init; } 
    /// <summary>
    /// Message amended.
    /// </summary>
    public IsoMax100KBinary? MessageAmended { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        // Not sure how to serialize AmendedData, multiplicity Unknown
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalMessage is IsoMax100KBinary OriginalMessageValue)
        {
            writer.WriteStartElement(null, "OrgnlMsg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100KBinary(OriginalMessageValue)); // data type Max100KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (MessageAmended is IsoMax100KBinary MessageAmendedValue)
        {
            writer.WriteStartElement(null, "MsgAmdd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax100KBinary(MessageAmendedValue)); // data type Max100KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transaction102 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
