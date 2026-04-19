const mobileMenuButton = document.getElementById("mobile-menu-button");
const mobileMenuFlyout = document.getElementById("mobile-menu-flyout");

if (mobileMenuButton && mobileMenuFlyout) {
	mobileMenuButton.addEventListener("click", () => {
		const isOpen = mobileMenuFlyout.classList.toggle("open");
		mobileMenuButton.setAttribute("aria-expanded", isOpen ? "true" : "false");
		mobileMenuFlyout.setAttribute("aria-hidden", isOpen ? "false" : "true");
	});

	mobileMenuFlyout.querySelectorAll("a").forEach((link) => {
		link.addEventListener("click", () => {
			mobileMenuFlyout.classList.remove("open");
			mobileMenuButton.setAttribute("aria-expanded", "false");
			mobileMenuFlyout.setAttribute("aria-hidden", "true");
		});
	});

	window.addEventListener("resize", () => {
		if (window.innerWidth >= 1200) {
			mobileMenuFlyout.classList.remove("open");
			mobileMenuButton.setAttribute("aria-expanded", "false");
			mobileMenuFlyout.setAttribute("aria-hidden", "true");
		}
	});
};

document.addEventListener("DOMContentLoaded", () => {
    const activeItem = document.querySelector('.faq-item.active');

    if (activeItem) {
        const answer = activeItem.querySelector('.faq-answer');
        answer.style.height = answer.scrollHeight + 'px';
        answer.style.opacity = '1';
    }
});

document.querySelectorAll('.faq-question').forEach(button => {
        button.addEventListener('click', () => {
            const item = button.closest('.faq-item');
            const answer = item.querySelector('.faq-answer');
            const openItem = document.querySelector('.faq-item.active');

            if (openItem && openItem !== item) {
                closeItem(openItem);
            }

            if (item.classList.contains('active')) {
                closeItem(item);
            } else {
                openItemFunc(item);
            }
        });
});

    function openItemFunc(item) {
    const answer = item.querySelector('.faq-answer');

    item.classList.add('active');

    answer.style.height = answer.scrollHeight + "px";

    answer.addEventListener('transitionend', function handler() {
        answer.style.height = "auto";
    answer.removeEventListener('transitionend', handler);
    });
};

    function closeItem(item) {
    const answer = item.querySelector('.faq-answer');

    answer.style.height = answer.scrollHeight + "px";

    answer.offsetHeight;

    answer.style.height = "0px";

    item.classList.remove('active');
};