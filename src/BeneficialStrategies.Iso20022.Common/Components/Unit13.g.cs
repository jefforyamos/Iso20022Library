﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Unit13.  ISO2002 ID# _cFAuQXwhEeuQY_68iqAoCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about units to transfer.
/// </summary>
public partial record Unit13
     : IIsoXmlSerilizable<Unit13>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of units.
    /// </summary>
    public required IsoDecimalNumber UnitsNumber { get; init; } 
    /// <summary>
    /// Date the investor or its agent placed the original order.
    /// </summary>
    public IsoISODate? OrderDate { get; init; } 
    /// <summary>
    /// Date the investor purchased the financial instrument.
    /// </summary>
    public IsoISODate? AcquisitionDate { get; init; } 
    /// <summary>
    /// Certificate representing the security.
    /// </summary>
    public IsoMax35Text? CertificateNumber { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    /// <summary>
    /// Reference to the units number. This may be the order reference of the original acquisition, the identification of a lot, a client reference, a sub-position reference or other related reference.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    
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
        writer.WriteStartElement(null, "UnitsNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(UnitsNumber)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
        if (OrderDate is IsoISODate OrderDateValue)
        {
            writer.WriteStartElement(null, "OrdrDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OrderDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (AcquisitionDate is IsoISODate AcquisitionDateValue)
        {
            writer.WriteStartElement(null, "AcqstnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(AcquisitionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (CertificateNumber is IsoMax35Text CertificateNumberValue)
        {
            writer.WriteStartElement(null, "CertNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CertificateNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Group1Or2Units is UKTaxGroupUnit1Code Group1Or2UnitsValue)
        {
            writer.WriteStartElement(null, "Grp1Or2Units", xmlNamespace );
            writer.WriteValue(Group1Or2UnitsValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Reference is IsoMax35Text ReferenceValue)
        {
            writer.WriteStartElement(null, "Ref", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static Unit13 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
