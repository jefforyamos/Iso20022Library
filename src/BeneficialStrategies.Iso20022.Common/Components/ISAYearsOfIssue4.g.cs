﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISAYearsOfIssue4.  ISO2002 ID# _3gENYkXfEeGY6MkiuzuPOA_-1915079820.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which the ISA plan is issued.
/// </summary>
public partial record ISAYearsOfIssue4
     : IIsoXmlSerilizable<ISAYearsOfIssue4>
{
    #nullable enable
    
    /// <summary>
    /// Current year of the Investment Saving Plan (ISA) that was issued during the current fiscal year.
    /// </summary>
    public CurrentYearType1Choice_? CurrentYear { get; init; } 
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    public PreviousYear2? PreviousYears { get; init; } 
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; } 
    
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
        if (CurrentYear is CurrentYearType1Choice_ CurrentYearValue)
        {
            writer.WriteStartElement(null, "CurYr", xmlNamespace );
            CurrentYearValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CshCmpntInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CashComponentIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (PreviousYears is PreviousYear2 PreviousYearsValue)
        {
            writer.WriteStartElement(null, "PrvsYrs", xmlNamespace );
            PreviousYearsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrentYearSubscriptionDetails is SubscriptionInformation1 CurrentYearSubscriptionDetailsValue)
        {
            writer.WriteStartElement(null, "CurYrSbcptDtls", xmlNamespace );
            CurrentYearSubscriptionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ISAYearsOfIssue4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
