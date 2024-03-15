using System;
using BuberBreakfast.Contracts.Breakfast.CreateBreakfastRequest;
using BuberBreakfast.Contracts.Breakfast.CreateBreakfastResponse;
using BuberBreakfast.Contracts.Breakfast.UpsertBreakfastRequest;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        ErrorOr<Created> CreateBreakfast(Breakfast breakfast);
        ErrorOr<Deleted> DeleteBreakfast(Guid id);
        ErrorOr<Breakfast> GetBreakfast(Guid id);
        ErrorOr<UpsertedBreakfast> UpsertBreakfast(Breakfast breakfast);
    }
}