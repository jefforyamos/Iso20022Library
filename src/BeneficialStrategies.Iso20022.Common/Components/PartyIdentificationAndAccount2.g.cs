﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount2.  ISO2002 ID# _Ur_zEdp-Ed-ak6NoX_4Aeg_-1678025203.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
public partial record PartyIdentificationAndAccount2
     : IIsoXmlSerilizable<PartyIdentificationAndAccount2>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required PartyIdentification1Choice_ PartyIdentification { get; init; } 
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    public AccountIdentification1? AccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    public IsoMax35Text? ProcessingReference { get; init; } 
    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    public DateAndDateTimeChoice_? ProcessingDate { get; init; } 
    
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
        if (AccountIdentification is AccountIdentification1 AccountIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctId", xmlNamespace );
            AccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingReference is IsoMax35Text ProcessingReferenceValue)
        {
            writer.WriteStartElement(null, "PrcgRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessingReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessingDate is DateAndDateTimeChoice_ ProcessingDateValue)
        {
            writer.WriteStartElement(null, "PrcgDt", xmlNamespace );
            ProcessingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PartyIdentificationAndAccount2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
