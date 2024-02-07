﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification10.  ISO2002 ID# _56x2kUmwEeaw890XtoVB-Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a financial institution.
/// </summary>
public partial record FinancialInstitutionIdentification10
     : IIsoXmlSerilizable<FinancialInstitutionIdentification10>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public required FinancialInstitutionIdentification8Choice_ Party { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
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
        writer.WriteStartElement(null, "Pty", xmlNamespace );
        Party.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (LEI is IsoLEIIdentifier LEIValue)
        {
            writer.WriteStartElement(null, "LEI", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(LEIValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static FinancialInstitutionIdentification10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
