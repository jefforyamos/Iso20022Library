﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IncentivePremium4.  ISO2002 ID# _SxQ8AbIXEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash premium made available if the securities holder consents or participates to an event.
/// </summary>
public partial record IncentivePremium4
     : IIsoXmlSerilizable<IncentivePremium4>
{
    #nullable enable
    
    /// <summary>
    /// Description of the premium.
    /// </summary>
    public IsoMax350Text? Description { get; init; } 
    /// <summary>
    /// Cash premium paid per security, per vote or per attendee.
    /// </summary>
    public required PriceRateOrAmount3Choice_ Amount { get; init; } 
    /// <summary>
    /// Type of incentive premium.
    /// </summary>
    public required IncentivePremiumType1Choice_ Type { get; init; } 
    /// <summary>
    /// Date/time for the payment of the premium.
    /// </summary>
    public DateFormat3Choice_? PaymentDate { get; init; } 
    
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
        if (Description is IsoMax350Text DescriptionValue)
        {
            writer.WriteStartElement(null, "Desc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(DescriptionValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PaymentDate is DateFormat3Choice_ PaymentDateValue)
        {
            writer.WriteStartElement(null, "PmtDt", xmlNamespace );
            PaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IncentivePremium4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
