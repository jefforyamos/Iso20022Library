﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralBusinessInformationSearchCriteria1.  ISO2002 ID# _51l8cZlZEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for business information.
/// </summary>
public partial record GeneralBusinessInformationSearchCriteria1
     : IIsoXmlSerilizable<GeneralBusinessInformationSearchCriteria1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous reference assigned to a general business information system.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    /// <summary>
    /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
    /// </summary>
    public CharacterSearch1Choice_? Subject { get; init; } 
    /// <summary>
    /// Further information about the criticality or importance of a general business information system.
    /// </summary>
    public InformationQualifierType1? Qualifier { get; init; } 
    
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
        if (Reference is IsoMax35Text ReferenceValue)
        {
            writer.WriteStartElement(null, "Ref", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Subject is CharacterSearch1Choice_ SubjectValue)
        {
            writer.WriteStartElement(null, "Sbjt", xmlNamespace );
            SubjectValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Qualifier is InformationQualifierType1 QualifierValue)
        {
            writer.WriteStartElement(null, "Qlfr", xmlNamespace );
            QualifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static GeneralBusinessInformationSearchCriteria1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
