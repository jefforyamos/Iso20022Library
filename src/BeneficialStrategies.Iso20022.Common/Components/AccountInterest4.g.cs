﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountInterest4.  ISO2002 ID# _wDb1Aa6FEeexrtTFgmVD3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the interest that applies to the account at a particular moment in time.
/// </summary>
public partial record AccountInterest4
     : IIsoXmlSerilizable<AccountInterest4>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    public InterestType1Choice_? Type { get; init; } 
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    public Rate4? Rate { get; init; } 
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    public DateTimePeriod1? FromToDate { get; init; } 
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    public IsoMax35Text? Reason { get; init; } 
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    public TaxCharges2? Tax { get; init; } 
    
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
        if (Type is InterestType1Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Rate is Rate4 RateValue)
        {
            writer.WriteStartElement(null, "Rate", xmlNamespace );
            RateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FromToDate is DateTimePeriod1 FromToDateValue)
        {
            writer.WriteStartElement(null, "FrToDt", xmlNamespace );
            FromToDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Reason is IsoMax35Text ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ReasonValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Tax is TaxCharges2 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountInterest4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
