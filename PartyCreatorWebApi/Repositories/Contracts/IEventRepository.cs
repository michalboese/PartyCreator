﻿using PartyCreatorWebApi.Dtos;
using PartyCreatorWebApi.Entities;

namespace PartyCreatorWebApi.Repositories.Contracts
{
    public interface IEventRepository
    {
        Task<Event> CreateEvent(Event _event);
        Task<List<Event>> ListEventsMadeByUser(int creatorId);
        Task<List<Event>> ListEventsJoinedByUser(int userId);
        Task<Event> GetEventDetails(int id);
        Task<InviteList> InviteToEvent(InviteList invitetList);
        Task<InviteList> CheckInviteList(InviteList inviteList);
        Task<GuestList> CheckGuestList(GuestList guestList);
        Task<InviteList> DeleteInvite(int id);
        Task<GuestList> AddToGuestList(GuestList guestList);
        Task<List<Event>> ListFinishedEvents(int userId);
        Task<List<GuestList>> GetGuestsFromEvent(int id);
        Task<List<AllGuestList>> GetGuestsUsers(int eventId);
        Task<List<AllGuestList>> GetInvitedUsers(int eventId);
        Task<List<AllGuestList>> GetAllGuestsList(int eventId);


    }
}
