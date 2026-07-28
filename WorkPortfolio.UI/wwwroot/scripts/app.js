(() => {
    const state = {
        initialized: false,
        observer: null
    };

    function setActiveNav(sectionId) {
        document.querySelectorAll('[data-scroll-target]').forEach((link) => {
            const isActive = link.getAttribute('data-scroll-target') === sectionId;
            link.classList.toggle('is-active', isActive);
        });
    }

    function scrollToSection(sectionId) {
        const section = document.getElementById(sectionId);
        if (!section) {
            return;
        }

        section.scrollIntoView({
            behavior: 'smooth',
            block: 'start'
        });
    }

    function ensureObserver() {
        const sections = document.querySelectorAll('[data-scroll-section]');
        if (!sections.length) {
            return false;
        }

        if (state.observer) {
            state.observer.disconnect();
        }

        state.observer = new IntersectionObserver((entries) => {
            const visible = entries
                .filter((entry) => entry.isIntersecting)
                .sort((a, b) => b.intersectionRatio - a.intersectionRatio)[0];

            if (visible?.target?.id) {
                setActiveNav(visible.target.id);
            }
        }, {
            rootMargin: '-20% 0px -45% 0px',
            threshold: [0.2, 0.35, 0.6]
        });

        sections.forEach((section) => state.observer.observe(section));
        return true;
    }

    function initializePortfolioInteractions() {
        if (!document.querySelector('[data-portfolio-shell]')) {
            window.setTimeout(initializePortfolioInteractions, 150);
            return;
        }

        if (!state.initialized) {
            document.addEventListener('click', (event) => {
                const target = event.target.closest('[data-scroll-target]');
                if (!target) {
                    return;
                }

                const sectionId = target.getAttribute('data-scroll-target');
                if (!sectionId) {
                    return;
                }

                event.preventDefault();
                scrollToSection(sectionId);
                setActiveNav(sectionId);
            });

            state.initialized = true;
        }

        if (!ensureObserver()) {
            window.setTimeout(initializePortfolioInteractions, 150);
        }
    }

    window.portfolioShell = {
        refresh: initializePortfolioInteractions
    };

    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', initializePortfolioInteractions, { once: true });
    } else {
        initializePortfolioInteractions();
    }
})();
