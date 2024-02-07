﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstrument.  ISO2002 ID# _UuOntdp-Ed-ak6NoX_4Aeg_-1126591079.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentAccountOrFinancialInstrument1Choice;

/// <summary>
/// Instrument that has intrinsic monetary value, and may transfer value, the price of which may be obtained from a financial market, eg, a bond or a cheque.
/// </summary>
public partial record FinancialInstrument : InvestmentAccountOrFinancialInstrument1Choice_
     , IIsoXmlSerilizable<FinancialInstrument>
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    public required SecurityIdentification1Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, 'Class A', 'Class 2'.
    /// </summary>
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    public IsoMax140Text? ProductGroup { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryIdentification is IsoMax35Text SupplementaryIdentificationValue)
        {
            writer.WriteStartElement(null, "SplmtryId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SupplementaryIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ClassType is IsoMax35Text ClassTypeValue)
        {
            writer.WriteStartElement(null, "ClssTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClassTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DistributionPolicy is DistributionPolicy1Code DistributionPolicyValue)
        {
            writer.WriteStartElement(null, "DstrbtnPlcy", xmlNamespace );
            writer.WriteValue(DistributionPolicyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ProductGroup is IsoMax140Text ProductGroupValue)
        {
            writer.WriteStartElement(null, "PdctGrp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(ProductGroupValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static new FinancialInstrument Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
