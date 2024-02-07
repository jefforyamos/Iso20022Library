﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Driver2.  ISO2002 ID# _Xa1IQRytEey6gI8SKlv7rg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet vehicle driver.
/// </summary>
public partial record Driver2
     : IIsoXmlSerilizable<Driver2>
{
    #nullable enable
    
    /// <summary>
    /// Name of fleet driver.
    /// </summary>
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Fleet driver identification.
    /// </summary>
    public IsoMax70Text? Identification { get; init; } 
    /// <summary>
    /// Driving license details.
    /// </summary>
    public DrivingLicense2? DrivingLicense { get; init; } 
    /// <summary>
    /// Contains the employer information. 
    /// </summary>
    public IsoMax70Text? Employer { get; init; } 
    /// <summary>
    /// Contains the employee identification number as assigned by the fleet operator. 
    /// </summary>
    public IsoMax70Text? EmployeeIdentification { get; init; } 
    /// <summary>
    /// Contains the fleet driver's department number as assigned by the fleet operator.
    /// </summary>
    public IsoMax35Text? DepartmentNumber { get; init; } 
    /// <summary>
    /// Additional identification used for the driver.
    /// </summary>
    public TravelDocument2? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Date of birth of vehicle rental driver. 
    /// </summary>
    public IsoISODate? DateOfBirth { get; init; } 
    /// <summary>
    /// Additional fleet summary-level information. 
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        if (Name is IsoMax70Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(NameValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (Identification is IsoMax70Text IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(IdentificationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (DrivingLicense is DrivingLicense2 DrivingLicenseValue)
        {
            writer.WriteStartElement(null, "DrvgLic", xmlNamespace );
            DrivingLicenseValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Employer is IsoMax70Text EmployerValue)
        {
            writer.WriteStartElement(null, "Mplyr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(EmployerValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (EmployeeIdentification is IsoMax70Text EmployeeIdentificationValue)
        {
            writer.WriteStartElement(null, "MplyeeId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax70Text(EmployeeIdentificationValue)); // data type Max70Text System.String
            writer.WriteEndElement();
        }
        if (DepartmentNumber is IsoMax35Text DepartmentNumberValue)
        {
            writer.WriteStartElement(null, "DeptNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DepartmentNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalIdentification is TravelDocument2 AdditionalIdentificationValue)
        {
            writer.WriteStartElement(null, "AddtlId", xmlNamespace );
            AdditionalIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DateOfBirth is IsoISODate DateOfBirthValue)
        {
            writer.WriteStartElement(null, "DtOfBirth", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateOfBirthValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Driver2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
