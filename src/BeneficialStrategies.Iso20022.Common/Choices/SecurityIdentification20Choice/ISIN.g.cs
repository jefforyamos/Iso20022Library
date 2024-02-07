﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISIN.  ISO2002 ID# _SBIPUT9DEeWqd8_TqzDNuw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification20Choice;

/// <summary>
/// International Securities Identification Number (ISIN). A numbering system designed by the United Nation's International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
/// </summary>
public partial record ISIN : SecurityIdentification20Choice_
     , IIsoXmlSerilizable<ISIN>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// The International Securities Identification Number is a code allocated to financial instruments as well as referential instruments, as described in the ISO 6166 standard, associated with the minimum descriptive data.  The ISIN consists of a prefix using the alpha-2 country codes or reserved codes specified in ISO 3166 or other prefixes as may be determined by the Registration Authority for the ISO 6166 standard, a nine characters (alphanumeric) basic code and a check digit.
    /// </summary>
    public required IsoISINOct2015Identifier Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "ISIN", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISINOct2015Identifier(Value)); // data type ISINOct2015Identifier System.String
        writer.WriteEndElement();
    }
    public static new ISIN Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
