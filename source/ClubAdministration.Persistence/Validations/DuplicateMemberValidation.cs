using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ClubAdministration.Core.Entities;

namespace ClubAdministration.Persistence.Validations
{
  public class DuplicateMemberValidation : ValidationAttribute
  {
    private readonly UnitOfWork _unitOfWork;

    public DuplicateMemberValidation(UnitOfWork unitOfWork) : base()
    {
      _unitOfWork = unitOfWork;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      // TODO: Duplikat-Prüfung implementieren
      return ValidationResult.Success;
    }
  }
}
