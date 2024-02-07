﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligibilityDates1.  ISO2002 ID# _TmHJHdp-Ed-ak6NoX_4Aeg_742278644.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dates determining the entitlement.
/// </summary>
public partial record EligibilityDates1
     : IIsoXmlSerilizable<EligibilityDates1>
{
    #nullable enable
    
    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, e.g. record date, book close date.
    /// </summary>
    public required IsoISODate EntitlementFixingDate { get; init; } 
    
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
        writer.WriteStartElement(null, "EntitlmntFxgDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EntitlementFixingDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static EligibilityDates1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
