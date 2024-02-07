﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SubSchedule.  ISO2002 ID# _u7i5ReFWEeSvv6t4Ka7B7A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InterestPaymentSchedule1Choice;

/// <summary>
/// Specifies an interest payment schedule, that is an interest amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
public partial record SubSchedule : InterestPaymentSchedule1Choice_
     , IIsoXmlSerilizable<SubSchedule>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the interest payment schedule.
    /// </summary>
    public IsoMax35Text? InterestScheduleIdentification { get; init; } 
    /// <summary>
    /// Interest amount that must be paid at due date.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Latest date whereby the interest must be paid.
    /// </summary>
    public required IsoISODate DueDate { get; init; } 
    /// <summary>
    /// Further details on the interest payments.
    /// </summary>
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
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
        if (InterestScheduleIdentification is IsoMax35Text InterestScheduleIdentificationValue)
        {
            writer.WriteStartElement(null, "IntrstSchdlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(InterestScheduleIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DueDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(DueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax1025Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1025Text(AdditionalInformationValue)); // data type Max1025Text System.String
            writer.WriteEndElement();
        }
    }
    public static new SubSchedule Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
