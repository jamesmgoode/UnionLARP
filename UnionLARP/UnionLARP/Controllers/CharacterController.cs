using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnionLARP.Data;
using UnionLARP.Models.GameModels;
using System.Security.Claims;
using UnionLARP.Models;
using Microsoft.AspNetCore.Identity;

namespace UnionLARP.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CharacterController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var characters = _context.Characters.ToList();
            var currentCharacter = Character.GetCurrentCharacter(characters);
            return currentCharacter == null ? RedirectToAction("Create") : RedirectToAction("ViewCharacter", new { characterId = currentCharacter.Id });
        }

        public async Task<IActionResult> ViewCharacter(int characterId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var character = _context.Characters.Find(characterId);
            if (character == null)
            {
                return RedirectToAction("Index");
            }

            var user = await GetCurrentUserAsync();
            if (character.PlayerId != user.Id)
            {
                return RedirectToAction(nameof(CharacterController.Index));
            }

            return View(character);
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account", null);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Character character)
        {
            character.IsAlive = true;
            var user = await GetCurrentUserAsync();
            character.PlayerId = user.Id;

            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();

            var characterId = character.Id;

            return RedirectToAction(nameof(CharacterController.View), new { characterId = characterId });
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
