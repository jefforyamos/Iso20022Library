﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument12.  ISO2002 ID# _SdZNhdp-Ed-ak6NoX_4Aeg_70923680.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument12
     : IIsoXmlSerilizable<FinancialInstrument12>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification3Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
