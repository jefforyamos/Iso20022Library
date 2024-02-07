﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentIdentificationValidity2.  ISO2002 ID# _HEh0geL6EeWOD7aAy2fAcA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the date from which the financial instrument identification is valid.
/// </summary>
public partial record FinancialInstrumentIdentificationValidity2
     : IIsoXmlSerilizable<FinancialInstrumentIdentificationValidity2>
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Defines the date from which the instrument code is valid. This date can be before the actual issue date of an instrument for 'when-issued' securities, but may not be a date in the future for a new security.
    /// </summary>
    public IsoISODate? ISINValidFrom { get; init; } 
    
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
        if (FinancialInstrumentIdentification is SecurityIdentification19 FinancialInstrumentIdentificationValue)
        {
            writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
            FinancialInstrumentIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ISINValidFrom is IsoISODate ISINValidFromValue)
        {
            writer.WriteStartElement(null, "ISINVldFr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ISINValidFromValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrumentIdentificationValidity2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
