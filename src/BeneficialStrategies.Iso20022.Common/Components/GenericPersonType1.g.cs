﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GenericPersonType1.  ISO2002 ID# _lvDzgnFwEemaN4ndAVY1ZQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a generic type of identification requested for a person.
/// </summary>
public partial record GenericPersonType1
     : IIsoXmlSerilizable<GenericPersonType1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the private type for the customer identification is requested or not.
    /// </summary>
    public required IsoRequestedIndicator Requested { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public required PersonIdentificationSchemeName1Choice_ SchemeName { get; init; } 
    
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
        writer.WriteStartElement(null, "Reqd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRequestedIndicator(Requested)); // data type RequestedIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SchmeNm", xmlNamespace );
        SchemeName.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static GenericPersonType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
