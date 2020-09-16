# Overlay Demo Project

## Goal

Expand this project to provide a `OverlayNavigationPage` that displays its `OverlayControl` 
on top of a `NavigationPage`. The `OverlayControl` instance should be fixed in position at the bottom 
of the screen, and stay fixed whilst the user navigates from `MainPage` to `ChildPage`, and back from
`ChildPage` to `MainPage`

User interactions on the invisible part of the control should flow back to the `NavigationPage` and its 
descendants, user interactions on the `OverlayControl` should be captured by the overlay and not sent to 
the `NavigationPage` underneath

## Platforms

This control should work for both Android and iOS, using `Xamarin.Form` - the use of custom renderer
is absolutely fine.

## Constraints

You are free to use open-source components, no commercial components should be used.
Please provide your solution as part of this project.

## Examples

This illustrates the behaviour the Podcast.app from Apple. Notice how the bottom control sits on top of the 
page, and does not propagate events like taps to the underlying page

![Demo podcast app](demo.gif)


