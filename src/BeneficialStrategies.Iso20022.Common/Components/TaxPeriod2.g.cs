﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxPeriod2.  ISO2002 ID# _zCdv5a9fEeen6L7OP7lnvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Period of time details related to the tax payment.
/// </summary>
public partial record TaxPeriod2
     : IIsoXmlSerilizable<TaxPeriod2>
{
    #nullable enable
    
    /// <summary>
    /// Year related to the tax payment.
    /// </summary>
    public IsoISODate? Year { get; init; } 
    /// <summary>
    /// Identification of the period related to the tax payment.
    /// </summary>
    public TaxRecordPeriod1Code? Type { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for which the tax report is provided.
    /// </summary>
    public DatePeriod2? FromToDate { get; init; } 
    
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
        if (Year is IsoISODate YearValue)
        {
            writer.WriteStartElement(null, "Yr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(YearValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (Type is TaxRecordPeriod1Code TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            writer.WriteValue(TypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FromToDate is DatePeriod2 FromToDateValue)
        {
            writer.WriteStartElement(null, "FrToDt", xmlNamespace );
            FromToDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TaxPeriod2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
