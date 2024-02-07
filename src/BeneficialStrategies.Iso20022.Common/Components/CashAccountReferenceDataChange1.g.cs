﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccountReferenceDataChange1.  ISO2002 ID# _k2l3k-5NEeCisYr99QEiWA_603606073.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
public partial record CashAccountReferenceDataChange1
     : IIsoXmlSerilizable<CashAccountReferenceDataChange1>
{
    #nullable enable
    
    /// <summary>
    /// Identifies the cash account for which the changes are listed in the advice.
    /// </summary>
    public required CashAccount24 CashAccountIdentification { get; init; } 
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    public required IsoMax35Text FieldName { get; init; } 
    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    public required IsoMax350Text OldFieldValue { get; init; } 
    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    public required IsoMax350Text NewFieldValue { get; init; } 
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
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
        writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
        CashAccountIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FldNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(FieldName)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OdFldVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(OldFieldValue)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "NewFldVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(NewFieldValue)); // data type Max350Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OprTmStmp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(OperationTimeStamp)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
    }
    public static CashAccountReferenceDataChange1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
