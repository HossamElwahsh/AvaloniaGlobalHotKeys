﻿using System;
using GlobalHotKeys;
using GlobalHotKeys.Native.Types;

void HotKeyPressed(HotKey hotKey) =>
  Console.WriteLine($"HotKey Pressed: Id = {hotKey.Id}, Key = {hotKey.Key}, Modifiers = {hotKey.Modifiers}");

using var hotKeyManager = new HotKeyManager();
using var subscription = hotKeyManager.HotKeyPressed.Subscribe(HotKeyPressed);
using var shift1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Shift);
using var ctrl1 = hotKeyManager.Register(VirtualKeyCode.KEY_1, Modifiers.Control);

Console.WriteLine("Listening for HotKeys...");
Console.ReadLine();
