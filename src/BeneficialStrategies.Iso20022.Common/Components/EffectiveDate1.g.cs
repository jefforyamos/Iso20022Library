﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EffectiveDate1.  ISO2002 ID# _oxDxcDceEeOA3chqL9a4Rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and date parameters.
/// </summary>
public partial record EffectiveDate1
     : IIsoXmlSerilizable<EffectiveDate1>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the SSI is effective. If the SSI is effective on a future date, then the date must be provided.
    /// </summary>
    public required IsoISODate EffectiveDate { get; init; } 
    /// <summary>
    /// Specifies how the SSI update effective date is to be applied.
    /// </summary>
    public ExternalEffectiveDateParameter1Code? EffectiveDateParameter { get; init; } 
    
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
        writer.WriteStartElement(null, "FctvDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EffectiveDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (EffectiveDateParameter is ExternalEffectiveDateParameter1Code EffectiveDateParameterValue)
        {
            writer.WriteStartElement(null, "FctvDtParam", xmlNamespace );
            writer.WriteValue(EffectiveDateParameterValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static EffectiveDate1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
