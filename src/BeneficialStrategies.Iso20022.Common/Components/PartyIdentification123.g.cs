﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification123.  ISO2002 ID# _-rulm4ftEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and references.
/// </summary>
public partial record PartyIdentification123
     : IIsoXmlSerilizable<PartyIdentification123>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required PartyIdentification113 PartyIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    public IsoMax35Text? ProcessingReference { get; init; } 
    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    public DateAndDateTime2Choice_? ProcessingDate { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
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
        writer.WriteStartElement(null, "PtyId", xmlNamespace );
        PartyIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProcessingReference is IsoMax35Text ProcessingReferenceValue)
        {
            writer.WriteStartElement(null, "PrcgRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessingReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessingDate is DateAndDateTime2Choice_ ProcessingDateValue)
        {
            writer.WriteStartElement(null, "PrcgDt", xmlNamespace );
            ProcessingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ContactPerson is ContactIdentification2 ContactPersonValue)
        {
            writer.WriteStartElement(null, "CtctPrsn", xmlNamespace );
            ContactPersonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification123 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
