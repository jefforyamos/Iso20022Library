﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification25.  ISO2002 ID# _Pb059Np-Ed-ak6NoX_4Aeg_-72138267.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, or a non-financial institution.
/// </summary>
public partial record PartyIdentification25
     : IIsoXmlSerilizable<PartyIdentification25>
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax70Text Name { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a party using a proprietary identification scheme.
    /// </summary>
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    /// <summary>
    /// Identification of a non-financial institution.
    /// </summary>
    public IsoBEIIdentifier? BEI { get; init; } 
    
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
        writer.WriteStartElement(null, "Nm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax70Text(Name)); // data type Max70Text System.String
        writer.WriteEndElement();
        if (ProprietaryIdentification is GenericIdentification4 ProprietaryIdentificationValue)
        {
            writer.WriteStartElement(null, "PrtryId", xmlNamespace );
            ProprietaryIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BEI is IsoBEIIdentifier BEIValue)
        {
            writer.WriteStartElement(null, "BEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoBEIIdentifier(BEIValue)); // data type BEIIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static PartyIdentification25 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
